namespace SpaceInvaders
{
    class SpecialEnemy : Entity
    {
        int moveNow = 0;

        public SpecialEnemy(char visualRepresentation): base(visualRepresentation)
        {

        }


        public override void Update()
        {
            moveNow++;

            if(position.x==70)
            {
                visualRepresentation = ' ';
            }
            else if(moveNow==4)
            {
                Move(position.x + 1, position.y);
                moveNow = 0;
            }
        }
    }
}
