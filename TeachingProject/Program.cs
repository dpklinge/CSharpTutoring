// See https://aka.ms/new-console-template for more information
using TeachingProject;

Console.WriteLine("Starting the program");
Vehicle myVehicle = new Vehicle(1,2,3);
Vehicle myVehicle2 = new Vehicle();
var amountToMove = 5;
myVehicle.GoForwards(amountToMove);
myVehicle.GoForwards(.1f);

Garage myGarage = new Garage();
myGarage.StoreVehicle(myVehicle);

Console.WriteLine("Hello, World! My sum is: " );

public class Vehicle
{
    public int x = 0;
    public int y = 0;
    public int z = 0;
    public Vehicle(int xProvided, int yProvided, int zProvided) {
        x = xProvided;
        y = yProvided;
        z = zProvided;
    }
    public Vehicle()
    {
    }

    public void GoForwards(int amount)
    {
        z += amount;
    }

    public void GoForwards(float amount)
    {
        z = (int)(z + amount);
    }
}

