using Exo08.CustomEnums;

namespace Exo08.Models
{
    public struct Card
    {
        public CardColorEnum Color;
        public CardValueEnum Value;

        public string GetInfo()
        {
            return $"{Value}   \t {Color}";
        }
    }
}
