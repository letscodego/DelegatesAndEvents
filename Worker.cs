namespace DelegatesAndEvents
{
    //If we do need delegate we can use this approch.
    //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
    public class Worker
    {
        //If we don't need delegate and we use it as event, we can use this approch as it's clean and short
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
            
        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                Thread.Sleep(1000);
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
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del != null) 
                del(this, new WorkPerformedEventArgs(hours, workType));
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
