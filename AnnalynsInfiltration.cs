using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        bool spyCondition = knightIsAwake || archerIsAwake || prisonerIsAwake;

        return spyCondition;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        bool signalCondition = !archerIsAwake && prisonerIsAwake;

        return signalCondition;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        var freedomCondition = (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
                            || (knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
                            || (!knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
                            || (!knightIsAwake && !archerIsAwake && prisonerIsAwake && !petDogIsPresent)
                            || (knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent);

        return freedomCondition;
    }
}