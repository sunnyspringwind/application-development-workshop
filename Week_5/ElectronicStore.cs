using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    // List to hold ElectronicDevice objects
    private List<ElectronicDevice> devices;

    // Constructor
    public ElectronicsStore()
    {
        devices = new List<ElectronicDevice>();
    }

    // Add a device
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to store.");
    }

    // Remove a device
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
            Console.WriteLine($"{device.Brand} removed from store.");
        else
            Console.WriteLine($"{device.Brand} not found in store.");
    }

    // Show all device details
    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n--- All Devices in Store ---");
        foreach (var device in devices)
        {
            // Call common info
            device.ShowInfo();

            // Downcast to call child-specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}
