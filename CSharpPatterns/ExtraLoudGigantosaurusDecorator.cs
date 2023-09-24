using System;

// Класс ExtraLoudGigantosaurusDecorator, добавляющий еще большую громкость к реву гигантозавра
class ExtraLoudGigantosaurusDecorator : GigantosaurusDecorator
{
    public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus) : base(gigantosaurus)
    {
    }

    public override void Roar()
    {
        Console.WriteLine("ExtraLoudGigantosaurusDecorator: RRRRRROOOOAAAAARRRRR!!!!");
        base.Roar();
    }
}
