using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VoiceRoom.DAL_Test.Fixture
{
    [CollectionDefinition("SystemCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {

    }
}
