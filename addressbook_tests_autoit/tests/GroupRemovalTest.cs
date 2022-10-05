using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        [Test]

        public void TestGroupRemoval()
        {
            if(app.Groups.GetGroupList().Count == 1)
            {
                app.Groups.Add(new GroupData { Name = "Test Group" });
            }

            int index = 1;
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(index);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(index);

            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups.Count, newGroups.Count);
            Assert.AreEqual(newGroups, oldGroups);
        }
    }
}
