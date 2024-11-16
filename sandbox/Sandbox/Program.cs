using System;
using System.Collections.Generic;
using System.Linq;

abstract class SmartDevice
{
    public string _name;
    private bool _isOn;
    private DateTime? _turnedOnTime;

    protected SmartDevice(string name)
    {
        _name = name;
        _isOn = false;
        _turnedOnTime = null;
    }

    public virtual void TurnOn()
    {
        if (!_isOn)
        {
            _isOn = true;
            _turnedOnTime = DateTime.Now;
            Console.WriteLine($"{_name} is now ON.");
        }
    }

    public virtual void TurnOff()
    {
        if (_isOn)
        {
            _isOn = false;
            _turnedOnTime = null;
            Console.WriteLine($"{_name} is now OFF.");
        }
    }

    public bool IsDeviceOn()
    {
        return _isOn;
    }

    public virtual TimeSpan GetOnDuration()
    {
        if (_isOn && _turnedOnTime.HasValue)
        {
            return DateTime.Now - _turnedOnTime.Value;
        }
        return TimeSpan.Zero;
    }

    public override string ToString()
    {
        return $"{_name} is {(_isOn ? "ON" : "OFF")}";
    }
}

class SmartLight : SmartDevice
{
    public SmartLight(string name) : base(name) { }

    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine($"The light '{_name}' illuminates the room.");
    }

    public override void TurnOff()
    {
        base.TurnOff();
        Console.WriteLine($"The light '{_name}' dims the room.");
    }
}

class SmartHeater : SmartDevice
{
    public SmartHeater(string name) : base(name) { }

    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine($"The heater '{_name}' starts warming the room.");
    }

    public override void TurnOff()
    {
        base.TurnOff();
        Console.WriteLine($"The heater '{_name}' stops warming the room.");
    }
}

class SmartTV : SmartDevice
{
    public SmartTV(string name) : base(name) { }

    public override void TurnOn()
    {
        base.TurnOn();
        Console.WriteLine($"The TV '{_name}' turns on and is ready for entertainment.");
    }

    public override void TurnOff()
    {
        base.TurnOff();
        Console.WriteLine($"The TV '{_name}' turns off, going into standby mode.");
    }
}

class Room
{
    public string _name { get; }
    private List<SmartDevice> Devices { get; }

    public Room(string name)
    {
        _name = name;
        Devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        Devices.Add(device);
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in Devices)
        {
            device.TurnOff();
        }
    }

    public void ReportAllDevices()
    {
        Console.WriteLine($"Devices in {_name}:");
        foreach (var device in Devices)
        {
            Console.WriteLine(device);
        }
    }

    public void ReportDevicesOn()
    {
        Console.WriteLine($"Devices ON in {_name}:");
        foreach (var device in Devices.Where(d => d.IsDeviceOn()))
        {
            Console.WriteLine(device);
        }
    }

    public void ReportLongestRunningDevice()
    {
        var longestRunning = Devices
            .Where(d => d.IsDeviceOn())
            .OrderByDescending(d => d.GetOnDuration())
            .FirstOrDefault();

        if (longestRunning != null)
        {
            Console.WriteLine($"{longestRunning._name} has been on the longest: {longestRunning.GetOnDuration()}.");
        }
        else
        {
            Console.WriteLine($"No devices are currently ON in {_name}.");
        }
    }
}

class House
{
    private List<Room> Rooms { get; }

    public House()
    {
        Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
    }

    public void ReportAllRooms()
    {
        foreach (var room in Rooms)
        {
            room.ReportAllDevices();
        }
    }
}

// Example usage
class Program
{
    static void Main()
    {
        // Create devices
        SmartDevice livingRoomLight = new SmartLight("Living Room Light");
        SmartDevice kitchenHeater = new SmartHeater("Kitchen Heater");
        SmartDevice bedroomTV = new SmartTV("Bedroom TV");

        // Create rooms and add devices
        Room livingRoom = new Room("Living Room");
        livingRoom.AddDevice(livingRoomLight);

        Room kitchen = new Room("Kitchen");
        kitchen.AddDevice(kitchenHeater);

        Room bedroom = new Room("Bedroom");
        bedroom.AddDevice(bedroomTV);

        // Create house and add rooms
        House house = new House();
        house.AddRoom(livingRoom);
        house.AddRoom(kitchen);
        house.AddRoom(bedroom);

        // Interact with devices
        livingRoomLight.TurnOn();
        kitchenHeater.TurnOn();

        livingRoom.ReportDevicesOn();
        livingRoom.ReportLongestRunningDevice();

        // Turn off all devices in the kitchen
        kitchen.TurnOffAllDevices();

        house.ReportAllRooms();
    }
}
