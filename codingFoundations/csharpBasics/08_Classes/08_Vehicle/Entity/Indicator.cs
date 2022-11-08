
    public class Indicator
    {
        //user will have the ability to "Read" this data
        //cannot directly write to .....
        public bool IsFlashing {get; private set;}

        public void TurnOn()
        {
            IsFlashing = true;
        }

        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
