Television myTV = new SonyTV();
myTV.Wattage = 100;
myTV.TurnOn();
myTV.ChannelUp();
myTV.ChannelDown();
myTV.TurnOff();

Lamp myLamp = new DesktopLamp();
myLamp.Wattage = 50;
myLamp.TurnOn();
myLamp.TurnOff(); // Removed ChannelUp() and ChannelDown()

interface IRemoteControl
{
    public void TurnOn();
    public void TurnOff();
    public void ChannelUp();
    public void ChannelDown();
}

abstract class PowerAppliance
{
    public bool PowerStatus;
    public int Wattage;
}

class Television : PowerAppliance, IRemoteControl // Added IRemoteControl
{
    public int Channel { get; set; }

    public virtual void TurnOn() { System.Console.WriteLine("Generic TV Turn on"); PowerStatus = true; }
    public virtual void TurnOff() { System.Console.WriteLine("Generic TV Turn off"); PowerStatus = false; }
    public virtual void ChannelUp() { System.Console.WriteLine("Generic TV Channel up"); }
    public virtual void ChannelDown() { System.Console.WriteLine("Generic TV Channel down"); }
}

class Lamp : PowerAppliance, IRemoteControl // Added IRemoteControl
{
    public virtual void TurnOn() { System.Console.WriteLine("Generic Lamp Turn on"); PowerStatus = true; }
    public virtual void TurnOff() { System.Console.WriteLine("Generic Lamp Turn off"); PowerStatus = false; }
    public virtual void ChannelUp() { System.Console.WriteLine("Lamp cannot change channel"); }
    public virtual void ChannelDown() { System.Console.WriteLine("Lamp cannot change channel"); }
}

class SonyTV : Television
{
    public override void TurnOn() { System.Console.WriteLine("Sony TV Turn on"); PowerStatus = true; }
    public override void TurnOff() { System.Console.WriteLine("Sony TV Turn off"); PowerStatus = false; }
    public override void ChannelUp() { System.Console.WriteLine("Sony TV Channel up"); }
    public override void ChannelDown() { System.Console.WriteLine("Sony TV Channel down"); }
}

class DesktopLamp : Lamp
{
    public override void TurnOn() { System.Console.WriteLine("Desktop Lamp Turn on"); PowerStatus = true; }
    public override void TurnOff() { System.Console.WriteLine("Desktop Lamp Turn off"); PowerStatus = false; }
}