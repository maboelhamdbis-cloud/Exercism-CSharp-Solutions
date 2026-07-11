static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return (knightIsAwake) ? false : true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (archerIsAwake == false && prisonerIsAwake == true) ? true : false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent == true && archerIsAwake == false) {return true;}
        else if (petDogIsPresent == false && prisonerIsAwake == true && archerIsAwake == false && knightIsAwake == false) {return true;} else {return false;}
    }
}
