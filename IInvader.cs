namespace TreehouseDefense
{
    interface IInvader
    {
        MapLocation Location { get; }
        
        bool HasScored { get; }

        int Health { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);

    }
}