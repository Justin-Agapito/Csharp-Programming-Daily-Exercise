## About This Project

A simple console-based Restaurant System built in C# to practice the basics of
Object-Oriented Programming (OOP). I created it using my own knowledge, with
W3Schools tutorials for reference and guidance from Claude (an AI assistant)
to understand how the pieces fit together.

### OOP concepts practiced
- **Classes and objects:** `Menu` and `MenuModel`, with objects created using `new`
- **Properties:** `Id`, `Name` and `Price` on each menu item
- **Encapsulation:** the menu list is `private`, and other code accesses it only
  through public methods
- **Methods:** `DisplayMenu()` shows the menu and `FindById()` searches it
- **Collections and loops:** a `List<MenuModel>` processed with `foreach`

### What it does
- Displays the restaurant menu
- Lets the user enter an item number and finds the matching item

### How to run
```bash
dotnet run
```