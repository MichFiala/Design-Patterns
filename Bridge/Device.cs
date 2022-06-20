namespace Bridge
{
	public abstract class Device
    {
		public abstract bool IsTurnedOn { get; }
		public abstract void TurnOn();
		public abstract void TurnOff();
		public abstract void SetVolume(int step);
	}
}