ComblockCurtain
--------------------------------
	Общее описание.

Контрол для WinForms и WPF представляет собой панель со скрытой клавиатурой. 
Клавиатура имеет телефонный формат: сетка из кнопок с цифрами от 0 до 9 в виде такого размещения:
1 2 3
4 5 6
7 8 9
  0
Разблокирует и убирает панель при вводе последовательности цифр, соответствующую значению константы LOCKER_SEQUENCE.
Может использоваться для скрытия пасхалок в программах.

	Состав проекта.

ComblockCurtainCommonLogic - функции и данные, общие для контролов ComblockCurtainControlWinForms и ComblockCurtainControlWpf.
ComblockCurtainControlWinForms - контрол для использования в приложениях WinForms.
ComblockCurtainControlWpf - контрол для использования в приложениях WPF.
ComblockCurtainTestAppWinForms - утилита для тестирования контрола ComblockCurtainControlWinForms.
ComblockCurtainTestAppWpf - утилита для тестирования контрола ComblockCurtainControlWpf.
