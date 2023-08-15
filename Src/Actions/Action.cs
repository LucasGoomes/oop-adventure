namespace oop_adventure;

public abstract class Action
{

    public virtual string Name => "";

    public virtual void Execute(string[] args)
    {
        //caso nao aconteça o override do metodo
        throw new Exception("Nothing to execute");
    }
}
