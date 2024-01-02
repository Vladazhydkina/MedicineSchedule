using System;

interface IMedicineStrategy
{
    void TakeMedicine();
}

class MondayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("Понеділок: Зранку - ліки №1, ввечері - ліки №4");
    }
}

class TuesdayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("Вівторок: Зранку - ліки №2, ввечері - ліки №4");
    }
}

class WednesdayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("Середа: Зранку - ліки №3, ввечері - ліки №4");
    }
}

class ThursdayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("Четвер: Зранку - ліки №1, ввечері - ліки №4");
    }
}

class FridayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("П'ятниця: Зранку - ліки №2, ввечері - ліки №4");
    }
}

class SaturdayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("Субота: Зранку - ліки №3, ввечері - ліки №4");
    }
}

class SundayMedicineStrategy : IMedicineStrategy
{
    public void TakeMedicine()
    {
        Console.WriteLine("Неділя: Перерва у прийомі ліків");
    }
}

class MedicineScheduler
{
    private IMedicineStrategy _medicineStrategy;

    public MedicineScheduler(IMedicineStrategy medicineStrategy)
    {
        _medicineStrategy = medicineStrategy;
    }

    public void SetMedicineStrategy(IMedicineStrategy medicineStrategy)
    {
        _medicineStrategy = medicineStrategy;
    }

    public void ExecuteMedicineSchedule()
    {
        _medicineStrategy.TakeMedicine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var mondayStrategy = new MondayMedicineStrategy();
        var tuesdayStrategy = new TuesdayMedicineStrategy();
        var wednesdayStrategy = new WednesdayMedicineStrategy();
        var thursdayStrategy = new ThursdayMedicineStrategy();
        var fridayStrategy = new FridayMedicineStrategy();
        var saturdayStrategy = new SaturdayMedicineStrategy();
        var sundayStrategy = new SundayMedicineStrategy();

        var scheduler = new MedicineScheduler(mondayStrategy);

        scheduler.ExecuteMedicineSchedule(); 
        scheduler.SetMedicineStrategy(tuesdayStrategy);
        scheduler.ExecuteMedicineSchedule();
        scheduler.SetMedicineStrategy(wednesdayStrategy);
        scheduler.ExecuteMedicineSchedule(); 
        scheduler.SetMedicineStrategy(thursdayStrategy);
        scheduler.ExecuteMedicineSchedule(); 
        scheduler.SetMedicineStrategy(fridayStrategy);
        scheduler.ExecuteMedicineSchedule(); 
        scheduler.SetMedicineStrategy(saturdayStrategy);
        scheduler.ExecuteMedicineSchedule(); 
        scheduler.SetMedicineStrategy(sundayStrategy);
        scheduler.ExecuteMedicineSchedule(); 

        Console.ReadLine();
    }
}

