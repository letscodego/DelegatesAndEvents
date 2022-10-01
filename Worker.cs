namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;
            
        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i+1, workType); 
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //1st approch to call an event
            //if (WorkPerformed != null)
            //    WorkPerformed(hours, WorkType);

            //2ed approch to call an event
            var del = WorkPerformed as WorkPerformedHandler;
            if(del != null) 
                del(hours, workType);
        }

        protected virtual void OnWorkCompleted()
        {
            //if (WorkCompleted( != null)
            //    WorkCompleted((this, EventArgs.Empty);

            var del = WorkCompleted as EventHandler;

            if (del != null) 
                del(this, EventArgs.Empty);
        }
    }
}
