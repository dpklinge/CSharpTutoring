// See https://aka.ms/new-console-template for more information
using TeachingProject;

Console.WriteLine("Starting the program");
// 'new Vehicle()' calls the constructor in the Vehicle class to create a new Vehicle object.
// You won't have a vehicle at all until new Vehicle is called at least once!
Vehicle myVehicle = new Vehicle(1,2,3);
Vehicle myVehicle2 = new Vehicle();
var amountToMove = 5;
// Tells the first vehicle we made to go forwards 5. Note that myVehicle2 will remain unaffected -
// each separate new Vehicle will maintain its own independent position
myVehicle.GoForwards(amountToMove);
myVehicle.GoForwards(.1f);

Garage myGarage = new Garage();
myGarage.StoreVehicle(myVehicle);


public class Vehicle
{
    public int x = 0;
    public int y = 0;
    public int z = 0;

    //A constructor - Constructors will have the same name as the class, and no return type
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
        z += amount; // Equivalent to z = z+amount;
    }

    public void GoForwards(float amount)
    {
        z = (int)(z + amount); // (int) is a 'cast' - it forces (z+amount) to be converted from float to int
    }
}

