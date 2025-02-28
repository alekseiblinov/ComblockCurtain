using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ComblockCurtainTestAppWpf
{
    /// <summary>
    /// Основа для классов вьюмоделей.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class ViewModelBase<TModel> : INotifyPropertyChanged
    {
        /// <summary>
        /// Режим работы формы редактора.
        /// </summary>
        public enum Mode
        {
            /// <summary>
            /// Добавление новой внешней ссылки (или нескольких)
            /// </summary>
            AddNew,
            /// <summary>
            /// Редактирование одной внешней ссылки.
            /// </summary>
            EditSingle,
            /// <summary>
            /// Редактирование нескольких элементов.
            /// </summary>
            EditMultiple
        }

        /// <summary>
        /// Существуют ли несохраненные изменения данных, которые внес пользователь.
        /// </summary>
        private bool _hasChanges;

        /// <summary>
        /// Были ли пользователем изменены данные.
        /// </summary>
        private bool _wasChanged;

        /// <summary>
        /// Модель данных в виде класса POCO, связанная с ViewModel.
        /// </summary>
        public TModel Model { get; set; }

        /// <summary>
        /// Существуют ли несохраненные изменения данных, которые внес пользователь.
        /// </summary>
        public virtual bool HasChanges
        {
            get => _hasChanges;
            set => SetPropertyValue(ref _hasChanges, value);
        }

        /// <summary>
        /// Были ли внесены изменения в данные.
        /// </summary>
        public bool WasChanged
        {
            get => _wasChanged;
            set => SetPropertyValue(ref _wasChanged, value);
        }

        /// <summary>
        /// Оповещает подписчиков об изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelBase(TModel model)
        {
            Model = model;
        }

        /// <summary>
        /// Оповещение подписчиков об изменении значения свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = Interlocked.CompareExchange(ref PropertyChanged, null, null);
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Присваивает резервному полю <paramref name="backingField"/> новое значение <paramref name="value"/>, если оно отличается от старого значения резервного поля, 
        /// и, при необходимости, оповещает подписчиков, что значение свойства с именем <paramref name="propertyName"/> изменились.
        /// Нужен для упрощения присваивания новых значений свойствам, и избавления от повторяющегося кода.
        /// </summary>
        /// <param name="backingField"> Резервное поле, значение которого нужно изменить </param>
        /// <param name="value"> Новое значение </param>
        /// <param name="validatingMethod"> Имя метода, ответственного за выполнение валидации при изменении свойства </param>
        /// <param name="setHasChanges"> Следует ли обозначить то, что пользователь внес изменения в данные </param>
        /// <param name="propertyName"> Имя изменившегося свойства </param>
        /// <returns> true, если значение поля было изменено или false в противном случае </returns>
        protected virtual bool SetPropertyValue<T>(ref T backingField, T value, Func<bool> validatingMethod = null, bool setHasChanges = false, [CallerMemberName] string propertyName = null)
        {
            // Если указанное свойство имеет то же значение, что ему планируется присвоить, то
            if (Equals(backingField, value))
            {
                // Выполнение присвоения не требуется, завершение работы метода.
                return false;
            }

            // Установка значения переменной (резервному полю), хранящей значение свойства.
            backingField = value;
            // Оповещение подписчиков об изменении значения свойства.
            OnPropertyChanged(propertyName);
            // Вызов метода, ответственного за выполнение проверки при изменении свойства.  
            validatingMethod?.Invoke();

            // Если требуется обозначить то, что пользователь внес изменения в данные, то
            if (setHasChanges)
            {
                // Взвод флага, обозначающего то, что пользователь внес изменения в данные.
                HasChanges = true;
            }

            return true;
        }

        /// <summary>
        /// Изменяет значение свойства у связанной модели в виде POCO.
        /// </summary>
        /// <param name="value"> Новое значение </param>
        /// <param name="validatingMethod"> Имя метода, ответственного за выполнение проверки (валидации) при изменении свойства </param>
        /// <param name="setHasChanges"> Следует ли обозначить то, что пользователь внес изменения в данные </param>
        /// <param name="propertyName"> Имя изменившегося свойства </param>
        protected void SetModelPropertyValue<T>(T value, Func<bool> validatingMethod = null, bool setHasChanges = false, [CallerMemberName] string propertyName = null)
        {
            // Если у типа объекта есть свойство с указанным именем, то
            if (VerifyPropertyName(propertyName))
            {
                // Получение значения указанного свойства у указанного объекта.
                PropertyInfo propertyInfo = Model.GetType().GetProperty(propertyName);

                // Если у POCO-объекта модели нет свойства с указанным именем, то
                if (propertyInfo == null)
                {
// В DEBUG-режиме генерируется исключение, если у POCO-объекта модели нет свойства с указанным именем.
#if DEBUG
                    throw new MissingMemberException(Model.GetType().FullName, propertyName);
#endif
                }

                object currentPropertyValue = propertyInfo.GetValue(Model);

                // Если указанное свойство имеет то же значение, что ему планируется присвоить, то
                if (Equals(currentPropertyValue, value))
                {
                    // Вызов метода, ответственного за выполнение проверки при изменении свойства. Его нужно вызывать в любом случае при установке значения для надёжности, даже если прежнее значение совпадает с новым.
                    validatingMethod?.Invoke();
                    // Выполнение присвоения не требуется, завершение работы метода.
                    return;
                }

                // Установка значения свойству.
                propertyInfo.SetValue(Model, value);
                // Оповещение подписчиков об изменении значения свойства.
                OnPropertyChanged(propertyName);
                // Вызов метода, ответственного за выполнение проверки при изменении свойства.  
                validatingMethod?.Invoke();

                // Если требуется обозначить то, что пользователь внес изменения в данные, то
                if (setHasChanges)
                {
                    // Взвод флага, обозначающего то, что пользователь внес изменения в данные.
                    HasChanges = true;
                }
            }
        }

        /// <summary>
        /// Есть ли у типа объекта вьюмодели свойство с указанным именем.
        /// </summary>
        private bool VerifyPropertyName(string propertyName)
        {
            bool result = true;

            if (propertyName == null || TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                result = false;
// В DEBUG-режиме генерируется исключение, если у объекта вьюмодели нет свойства с указанным именем.
#if DEBUG
                throw new MissingMemberException(GetType().FullName, propertyName);
#endif
            }

            return result;
        }
    }
}