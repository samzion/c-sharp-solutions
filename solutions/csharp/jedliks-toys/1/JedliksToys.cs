class RemoteControlCar
{
    public int DistanceCovered;
    public int BatteryLevel = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        
       return $"Driven {DistanceCovered} meters";
    }

    public string BatteryDisplay()
    {
        
        return BatteryLevel == 0 ? "Battery empty" : $"Battery at {BatteryLevel}%";
    }

    public void Drive()
    {
        if(BatteryLevel > 0){
            DistanceCovered = DistanceCovered + 20;
            BatteryLevel -= 1;
        }
        
    }
}
