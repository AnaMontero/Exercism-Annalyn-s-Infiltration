using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        bool canPerformAction = false;
        
        if (!knightIsAwake)
        {
            canPerformAction = true;
        }
        
        return canPerformAction;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        bool canPerformAction = false;
        
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            canPerformAction = true;
        }
        
        return canPerformAction;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        bool canPerformAction = false;
        
        if (!archerIsAwake && prisonerIsAwake)
        {
            canPerformAction = true;
        }
        
        return canPerformAction;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        //TODO: corregir método para que pasen todos los tests
        bool canPerformAction = false;
        
        if (!knightIsAwake && !archerIsAwake && prisonerIsAwake || petDogIsPresent)
        {
            canPerformAction = true;
        }
        
        return canPerformAction;
    }
}
