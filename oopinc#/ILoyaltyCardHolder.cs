using System;
namespace EDX_OOP_in_CSharp
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; set; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }
}
