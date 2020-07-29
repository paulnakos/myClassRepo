using System;
using Calculations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class TestCar
    {
        private Calculations.Truck _truck;
        private Calculations.Car _car;
        public TestCar()
        {
            _car = new Calculations.Car();
            _truck = new Calculations.Truck();
        }
        [DataTestMethod]
        [DataRow(100, "2005-10-1", 25)]
        public void TestHP(int HP, string dt, int newHP)
        {
            DateTime dt1 = Convert.ToDateTime(dt);
            _car = new Calculations.Car(HP, dt1);
            var result = _car.HPCalc();
            Assert.AreEqual(result, newHP);
        }
        [DataTestMethod]
        [DataRow(5, 4, 9)]
        [DataRow(6, 7, 13)]
        public void TestLoad(int load, int newLoad,int sum)
        {
            _truck  = new Truck(load);
           
            var result = _truck.Load(newLoad);
            Assert.AreEqual(result, sum);
        }

    }
}
