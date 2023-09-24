public class FlowerUpgrader<T> where T : Flower
{
    private T flower;

    public FlowerUpgrader(T flower)
    {
        this.flower = flower;
    }

    public void Upgrade()
    {
        flower.Price *= 1.15;
    }
}
