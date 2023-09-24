using System;

// Базовый класс декоратора, который также реализует интерфейс IGigantosaurus
abstract class GigantosaurusDecorator : IGigantosaurus
{
    protected IGigantosaurus gigantosaurus;

    public GigantosaurusDecorator(IGigantosaurus gigantosaurus)
    {
        this.gigantosaurus = gigantosaurus;
    }

    public virtual void Roar()
    {
        gigantosaurus.Roar();
    }
}