using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using TechStackCheck.AzureStorage.Table;
using TechStackCheck.Web.Models;
using TechStackCheck.Web.Services;
using Xunit;

namespace Tech_Stack_Check.Web.Tests
{
    public class TableStorageValuesServiceTest
    {
        [Fact]
        public async Task GetValue_Success_Test()
        {
            var mockAzureTableStorage = new Mock<IAzureTableStorage<Value>>();
            var mockResults = new List<Value>{ 
                new Value{PartitionKey="123"},
                new Value{PartitionKey="b"}
            };
            mockAzureTableStorage.Setup(s => s.GetList()).ReturnsAsync(mockResults);
            var service = new TableStorageValuesService(mockAzureTableStorage.Object);
            Assert.Equal(123, await service.GetValue(2));
        }
    }
}
