using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        bool canPerformAction = false;

        if (!knightIsAwake)
            canPerformAction = true;

        return canPerformAction;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        bool canPerformAction = false;

        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
            canPerformAction = true;

        return canPerformAction;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        bool canPerformAction = false;

        if (!archerIsAwake && prisonerIsAwake)
            canPerformAction = true;

        return canPerformAction;
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