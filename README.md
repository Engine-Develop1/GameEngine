# GameEngine

the GIAC(Game In A Console) game will be made in this engine  

## how it works
the engine is based on a few things dose are 

1. a start function for the main menu and the update function
2. an inventory system
3. and an database

```
public class Settings [...]
public class GeneralSystems
{
//the start function is responsible for the main menu and settings
void start() [...]
//the update function is responsible for taking user input 
void update() [...]
}
```

the settings class holds many types of information take a look in the ![GeneralSystems.cs](Code/GeneralSystems.cs)

> test

## how to use the engine

the engine starts with the ![GeneralSystems.cs](Code/GeneralSystems.cs) file where there is a function for starting it
```
void Start()
...
```
1. Make a new file in your project
```
using GameEngine;
public class ClassName : GeneralSystems
{
  public static void Main()
  {
     ClassName Classname = new ClassName();
     Classname.Start();
  }
  public void Start()
  {
    start();
  }
  //and the same with the update function
}
```
