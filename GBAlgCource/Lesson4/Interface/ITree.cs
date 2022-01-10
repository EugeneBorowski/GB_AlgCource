namespace GBAlgCource.Lesson4.Interface
{
    public interface ITree
    {
        int? Value { get; set; }
        /// <summary>
        /// Добавить узел
        /// </summary>
        /// <param name="value"></param>
        void AddItem(int value);
        /// <summary>
        /// Удалить узел по значению
        /// </summary>
        /// <param name="value"></param>
        void RemoveItem(int value);
        /// <summary>
        /// Получить узел дерева по значению
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Node GetNodeByValue(int value);
        /// <summary>
        /// Вывести дерево в консоль
        /// </summary>
        /// <param name="baseLevel"></param>
        void PrintTree(int baseLevel);
    }
}
