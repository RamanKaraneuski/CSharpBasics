using System;

// Класс LoudGigantosaurusDecorator, добавляющий громкость к реву гигантозавра
class LoudGigantosaurusDecorator : GigantosaurusDecorator
{
    public LoudGigantosaurusDecorator(IGigantosaurus gigantosaurus) : base(gigantosaurus)
    {
    }

    public override void Roar()
    {
        Console.WriteLine("LoudGigantosaurusDecorator: RRRROOOAAARRR!");
        base.Roar();
    }
}