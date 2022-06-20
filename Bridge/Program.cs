// See https://aka.ms/new-console-template for more information
using Bridge;

var device = new TV();
var remote = new Remote(device);

remote.TogglePower();
remote.VolumeUp();
