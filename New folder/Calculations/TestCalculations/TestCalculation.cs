using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class TestCalculation
    {
        private readonly Calculations.Calc _calc;
        public TestCalculation()
        {
            _calc = new Calculations.Calc();
        }
        [DataTestMethod]
        [DynamicData(nameof(GetData),DynamicDataSourceType.Method)]
        public void TestSum(int val1,int val2,int val3)
        {
            var result = _calc.Add(val1, val2);
            Assert.AreEqual(result, val3);
        }

        [DataTestMethod]
        [DataRow(2, 3, 6)]
        public void TestMulti(int val1, int val2, int val3)
        {
            var result = _calc.Multi(val1, val2);
            Assert.AreEqual(result, val3);
        }
        [DataTestMethod]
        [DataRow(7, 3, 4)]
        public void TestSub(int val1, int val2, int val3)
        {
            var result = _calc.Sub(val1, val2);
            Assert.AreEqual(result, val3);
        }
        [DataTestMethod]
        [DataRow(4, 2, 2)]
        [DataRow(1, 3, 0)]
        [DataRow(1, 0, 1)]
        public void TestDiv(int val1, int val2, int val3)
        {
            var result = _calc.Div(val1, val2);
            Assert.AreEqual(result, val3);
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { 4, 2, 6 };
            yield return new object[] { 10, 5, 15 };
            yield return new object[] { 3, 3, 6 };
        }

        //[TestClass]
        //public class TestCar
        //{
        //    private Calculations.Truck _truck;
        //    private Calculations.Car _car;
        //    public TestCar()
        //    {
        //        _car = new Calculations.Car();
        //        _truck = new Calculations.Truck();
        //    }
        //    [DataTestMethod]
        //    [DataRow(100, "2005-10-1", 25)]
        //    public void TestHP(int HP, string dt, int newHP)
        //    {
        //        DateTime dt1 = Convert.ToDateTime(dt);
        //        _car = new Calculations.Car(HP, dt1);
        //        var result = _car.HPCalc();
        //        Assert.AreEqual(result, newHP);
        //    }
        //    [DataTestMethod]
        //    [DataRow(5, 10)]

        //    public void TestLoad(int load, int newLoad)
        //    {
        //        var result = _truck.Load(load);
        //        Assert.AreEqual(result, newLoad);
        //    }

        //}
    }
    
}
