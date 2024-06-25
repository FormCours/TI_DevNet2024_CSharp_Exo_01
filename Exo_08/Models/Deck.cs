using Exo08.CustomEnums;

namespace Exo08.Models
{
    public struct Deck
    {
        public Card[] Cards;

        public void Initialize()
        {
            // On initialise un tableau de carte (Valeur par defaut -> Couleur: 0 / Valeur: 0)
            Cards = new Card[52];

            // On affecte une valeur a chaque carte
            int i = 0;
            foreach (CardColorEnum currentColor in Enum.GetValues(typeof(CardColorEnum)))
            {
                foreach(CardValueEnum currentValue in Enum.GetValues<CardValueEnum>())
                {
                    // Affectation de la couleur et de la valeur;
                    Cards[i].Color = currentColor;
                    Cards[i].Value = currentValue;

                    // On passe a la carte suivante
                    i++;
                }
            }
        }

        public void Shuffle(ShuffleDeckEnum shuffleDeck = ShuffleDeckEnum.French)
        {
            switch (shuffleDeck)
            {
                case ShuffleDeckEnum.French:
                    ShuffleFrench();
                    break;
                case ShuffleDeckEnum.Nicolas:
                    ShuffleNico();
                    return;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ShuffleFrench()
        {
            int nbShuffle = Random.Shared.Next(10, 21);

            List<Card> stack1 = Cards.ToList();
            List<Card> stack2 = new List<Card>();

            for (int i = 0; i < nbShuffle; i++)
            {
                while (stack1.Count > 0)
                {
                    // Génération aleatoire du nombre de cards qui devrait être deplacé
                    int nbCardRng = Random.Shared.Next(3, 15);

                    // Vérification du nombre de cards (Est ce qu'on dépace le nombre de la stack1)
                    int nbCard = Math.Min(nbCardRng, stack1.Count);

                    // Récuperation des cartes dans la 1er pile
                    List<Card> temp = stack1.Slice(0, nbCard);

                    // Suppression des cartes dans la 1er pile
                    stack1.RemoveRange(0, nbCard);

                    // Ajout des cartes dans la seconde pile
                    stack2.InsertRange(0, temp);
                }

                // On deplace la stack2 dans la stack1
                // Et on reset la stack2 (en cassant la ref)
                stack1 = stack2;
                stack2 = new List<Card>();
            }

            Cards = stack1.ToArray();
        }

        private void ShuffleNico()
        {
            Random.Shared.Shuffle(Cards);
        }
    }
}
