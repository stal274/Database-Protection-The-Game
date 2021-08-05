

abstract class Hit
{
    public abstract void Accept(IHitVisiter visiter);
}
class TargetHit : Hit
{
    public override void Accept(IHitVisiter visiter)
    {
        visiter.Visit(this);
    }
}
class EnviromentHit : Hit
{
    public override void Accept(IHitVisiter visiter)
    {
        visiter.Visit(this);
    }
}

class DoSomething : IHitVisiter
{
    void IHitVisiter.Visit(Hit hit)
    {

    }

    void IHitVisiter.Visit(TargetHit hit)
    {

    }

    void IHitVisiter.Visit(EnviromentHit hit)
    {

    }
}

interface IHitVisiter
{
    void Visit(Hit hit);
    void Visit(TargetHit hit);
    void Visit(EnviromentHit hit);
}
