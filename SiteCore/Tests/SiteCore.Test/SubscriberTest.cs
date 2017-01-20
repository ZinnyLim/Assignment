using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SiteCore.Business.Components;
using SiteCore.Business.Entities;
using Moq;
using SiteCore.Data;

namespace SiteCore.Test
{
    [TestClass]
    public class SubscriberTest
    {
        [TestMethod]
        public void AddSubscriberTest()
        {
            Subscriber sub = new Subscriber();
            sub.Name = "Test"; 
            sub.SubscribeDate = DateTime.Now;
            sub.Status = true; 
            //var chk = new Mock<ISubscriberDAC>();
            //chk.Setup(x => x.Create(sub)).Returns(true);

            var subObj = new SubscriberComponent();
            Assert.AreEqual(subObj.AddSubscriber(sub), true); 
        }
    }
}
