using System;

namespace ITGigsCommon
{
    public class CustomId
    {
        private string id;
        public CustomId()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
