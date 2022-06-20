namespace Bridge
{
	public class Remote
	{
		private readonly Device _device;
		public Remote(Device device)
		{
			_device = device;
		}
		public void VolumeUp() => _device.SetVolume(1);
		public void VolumeDown() => _device.SetVolume(-1);
		public void TogglePower()
		{
			if(_device.IsTurnedOn) _device.TurnOff();
            else _device.TurnOn();
		}
	}
}