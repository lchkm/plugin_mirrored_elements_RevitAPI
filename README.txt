# IsMirrored Plugin for Autodesk Revit

Плагин для обнаружения отзеркаленных элементов в Revit 2024.

## Функционал
- Определение всех FamilyInstance с свойством Mirrored
- Вывод количества в удобном интерфейсе
- Поддержка Revit 2024

## Установка
1 Вариант:
- Скачать [последнюю версию](releases/latest)
- Скопировать .bundle в `%APPDATA%\Autodesk\Revit\Addins`
2 Вариант:
- Установить Revit Add-in Manager в Revit
- Использовать плагин непосредственно внутри Revit

## Разработка
```bash
git clone https://github.com/lchkm/plugin_mirrored_elements_RevitAPI.git
cd IsMirroredPlugin
```
## Требуется для разработки:
- Visual Studio 2019+
- Revit SDK

## Лицензия
MIT