class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){return 40;}

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remaningTime){return (ExpectedMinutesInOven() - remaningTime);}

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int preparationTime){return (preparationTime * 2);}

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersNumber , int ovenTime){return (PreparationTimeInMinutes(layersNumber) + ovenTime);}
}
