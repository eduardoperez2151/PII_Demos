using System.Collections.Generic;

namespace Order
{

    public abstract class Order<T> where T : IOrderMember
    {
        protected List<T> members;

        protected Order()
        {
            this.members = new List<T>();
        }

        public void addMember(T member)
        {
            this.members.Add(member);
        }

        #region Abstracts 

        public abstract void Greet();

        #endregion
    }


}