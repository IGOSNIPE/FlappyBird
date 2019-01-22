using SFML;

namespace flappybird
{
    // abstract class - klasa, która ma pola czy też jakieś ciała metod, ale nie musi mieć wszystkich ciał metod
    interface IState // interfejs to "klasa", która nie ma pól ani ciał metod
    {
        bool Update();
        void Draw(SFML.Graphics.RenderWindow target);
    }
}
