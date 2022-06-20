namespace Bridge
{
	public class TV : Device
	{
		private int _volume;
		private bool _isTurnedOn;
		public override bool IsTurnedOn => _isTurnedOn;
		public override void SetVolume(int step) => _volume += step;
		public override void TurnOff() => _isTurnedOn = false;
		public override void TurnOn() => _isTurnedOn = true;
	}
}