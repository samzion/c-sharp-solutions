class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _batteryLevel = 100;
    private int _distanceCovered;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
        => _batteryLevel < _batteryDrain;

    public int DistanceDriven()
        => _distanceCovered;

    public void Drive()
    {
        if (BatteryDrained())
            return;

        _distanceCovered += _speed;
        _batteryLevel -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
        => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained() &&
               car.DistanceDriven() < _distance)
        {
            car.Drive();
        }

        return car.DistanceDriven() >= _distance;
    }
}