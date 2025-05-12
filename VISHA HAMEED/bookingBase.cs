using System;
using System.ComponentModel;

namespace VISHA_HAMEED
{
    public class bookingBase : IDisposable
    {
        private bool disposedValue = false; // To detect redundant calls

        // This method is needed to implement the IDisposable interface.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose of managed resources here
                }

                // Dispose of unmanaged resources here
                disposedValue = true;
            }
        }

        // Destructor
        ~bookingBase()
        {
            Dispose(false);
        }

        // Virtual method to be overridden in derived classes
        public virtual void GetBookingDetails()
        {
            // Base implementation (if any)
        }
    }
}