﻿namespace oop_adventure;

public abstract class Character
{
    public string Name { get; set; }
    public Character(string name)
    {
        Name = name;
    }
}
