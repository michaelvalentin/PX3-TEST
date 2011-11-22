// -----------------------------------------------------------------------
// <copyright file="Controler.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Calculator
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Controler
    {
        private Operation currentOperation;

        private MainWindow view;

        private Calc model;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public Controler(MainWindow view, Calc model)
        {
            this.view = view;
            view.OperationCalled += this.HandleOperation;
            this.model = model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newOperation"></param>
        public void HandleOperation(Operation newOperation)
        {
            this.Operate(currentOperation);
            currentOperation = newOperation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        private void Operate(Operation operation)
        {
            double currentValue = view.DisplayValue;
            string currentPosition = view.StoreIndex;

            switch (currentOperation)
            {
                case Operation.Addition:
                    model.Add(currentValue);
                    break;
                case Operation.Subtraction:
                    model.Subtract(currentValue);
                    break;
                case Operation.Division:
                    model.Divide(currentValue);
                    break;
                case Operation.Multiplication:
                    model.Multiply(currentValue);
                    break;
                case Operation.Recall:
                    model.Recall(currentPosition);
                    break;
            }

            view.DisplayValue = model.Result;
        }
    }
}
