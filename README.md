## Задание "Галактики"
Проект выполняется как консольное приложение .NET на языке C# <br/>
### Первичный запуск программы.
При запуске приложения, оно выполнялось с ошибками, мы не получали желаемый результат.<br/>
Нужно: <br/>
```
Tadpole  400,  Spiral
Pinwheel  25,  Spiral
Cartwheel, 500,  Lenticular
Small Magellanic Cloud .2,  Irregular
Andromeda  3,  Spiral
Maffei 1,  Elliptical
```
Что имеем: <br/>
```
Tadpole  400,  ConsoleApp_FirstApp.GType
Pinwheel  25,  ConsoleApp_FirstApp.GType
Cartwheel, 500,  ConsoleApp_FirstApp.GType
Small Magellanic Cloud .2,  ConsoleApp_FirstApp.GType
Andromeda  3,  ConsoleApp_FirstApp.GType
Maffei 1, 11,  ConsoleApp_FirstApp.GType
```
### Исправление первой ошибки кода.
Для начала производим отладку приложения, с точкой остановки на цикле foreach, а именно на строчке вывода: <br/>
```C#
foreach (Galaxy theGalaxy in theGalaxies)
{
    Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType);
}
```
При наведении на последнюю часть строки, мы видим что GalaxyType содержит свойство MyGType, а значение свойства установлено в Spiral. <br/>
Это даёт нам знать, что мы используем неправильный API. <br/>
Изменяем theGalaxy.GalaxyType на theGalaxy.GalaxyType.MyGType. <br/>
Проводим отладку и в окне "Горячая перезагрузка" нажимаем "Изменить" <br/>
Ищем даннную строчку кода и изменяем object на GType: <br/>
Было: <br/>
```C#
public object GalaxyType { get; set; }
```
Стало: <br/>
```C#
public GType GalaxyType { get; set; }
```
Удаляем точку остановки и перезапускаем программу, мы видим, что наши изменения помогли лучше отображать информацию, но есть одно но: <br/>
```
Tadpole  400,  Spiral
Pinwheel  25,  Spiral
Cartwheel, 500,  Lenticular
Small Magellanic Cloud .2,
Andromeda  3,  Spiral
Maffei 1,  Elliptical
```
<i>(в четвертой строчке, после запятой отстутсвует тип галактики)</i>

### Исправление второй ошибки кода.
Ставим точку остановки перед оператором switch:
```C#
public GType(char type)
```
Нажимаем перезапуск и наведясь на type нажимаем F5 пока не увидим 73'I' <br/>
После делаем шаг, и замечаем что case 'I' скипается, из-за  того что там не та буква, исправляем ошику. <br/>
После перезапуска и удаления точки остановки, видим качественный вывод. <br/>
```
Tadpole  400,  Spiral
Pinwheel  25,  Spiral
Cartwheel, 500,  Lenticular
Small Magellanic Cloud .2,  Irregular
Andromeda  3,  Spiral
Maffei 1,  Elliptical
```
### Используемые способы отладки.
- Точки остановки (устанавливаются кликом по левому полю напротив строки или клавишей F9)
- Пошаговое выполнение кода (F11 - заход внутрь вызовов методов; F10 - без захода в методы)
- Проверка переменных (раскрытие сложных объектов при наведении курсором)
- Перезапуск приложения в режиме отладки (Ctrl + Shift + F5)
- Изменение и продолжение
- Помощник по обработке исключений
