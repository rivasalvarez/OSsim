@@ -0,0 +1,248 @@
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSsimulator
{
    public class system // Maintains status of overall system and stores important parameters
    {
        // Member Fields
            // Quantum
            // Scheduling type
        
        // Constructors
        public system()
        {

        }

        // Methods
            // Initialize: Boots system, populates metadata and I/O cycle times, begins scheduling/processing
		    // Run:  Initiates processing, hands off control to processor
		    // Shut Down
    }

    public class metadata // Reads in data from specified file, saves it in array that later populates Class::Processor member queue. Functions as simulated non-volatile hard disk storage
    {
        // Member Fields
            // Queue<Type PCB>

        // Constructors
        public metadata()
        {

        }

        // Methods  
            // Read: Populates storage array and Class::System members (Potentially a constructor)
    }

    public class clock // Dependent on System Time
    {
        // Member Fields
		    // Time started
		    // Time stopped
		    // Stopwatch interval
		    // Started (yes or no)

        // Constructors
        public clock()
        {

        }

        // Methods   
		    // Start: Starts the timer
		    // Stop: Stops the timer
            // GetElapsedTime: Gets time elapsed from start
		    // StopWatch: Creates a stopwatch with desired value
		    // Convert: Converts cycles to ms
    }

    public class interruptManager // Interrupts will be handled by an Interrupt Management class.  The class will keep track of all processes that are currently waiting on an interrupt.  The class will implement a pulling method that checks if any of the interrupts have gone off, and then handle them appropriately. 
    {
        // Member Fields
            // Number of pending interrupts
		    // Queue <Type Interrupt>
		    // Class Clock

        // Constructors
        public interruptManager()
        {

        }

        // Methods  
		    // Create: Adds a new interrupt into the queue
		    // Remove: Removes interrupt after being serviced
		    // Service: Prints status to console 
    }

    public struct interrupt
    {
        // Member Fields
		    // Process number
            // Interrupt description
		    // Time needed
    }

    public class processor
    {
        // Member Fields
		    // Cycle time
            // New Queue <Type PCB>
		    // Ready Queue <Type PCB>
            // Running Queue <Type PCB>
            // Waiting Queue <Type PCB>
		    // Class::Timer

        // Constructors
        public processor()
        {

        }

        // Methods
		    // Swap Processes(P in processor, 1st P in Queue), prints status to console
            // Create(process), prints status to console
            // Remove(process), prints status to console
            // Manage I/O, prints status to console
            // Run(process), prints status to console
            // Enqueue 
    }

    public class pcb
    {
        // Member Fields
		    // State
		    // Cycles remaining
		    // I/O Status info: Flag for waiting for interrupt, I/O requirements
		    // Upcoming processes

        // Constructors
        public pcb()
        {

        }

        // Methods
		    // Data Logging: Every time a PCB is manipulated or modified, it logs the event to the hard drive and/or monitor depending on the configuration file
    }

    public class scheduler // Manages Queues in Class Processor
    {
        // Member Fields
		    // Priority Queue<PCB>
		    // Schedule type
		    // Preemptive (yes or no)

        // Constructors
        public scheduler()
        {

        }

        // Methods (This needs to be reevaluated for multiple scheduling types)
        	// Functions:
		    // Enqueue //Enqueue depending on the scheduling type.
		    // Dequeue //Gets the next PCB in the queue
    }

    public class device // Accepts process as argument that requires use of hardware I/O
    {
        // Member Fields
		    // Cycle Time

        // Constructors
        public device()
        {

        }

        // Methods
		    // Interrupt: Calls the appropriate function in the Class::Interrupt

    }

    public class monitor : device
    {
        // Member Fields

        // Constructors
        public monitor()
        {

        }

        // Methods
            // Output: Simulates Output to monitor, prints status to console
    }

    public class printer : device
    {
        // Member Fields

        // Constructors
        public printer()
        {

        }

        // Methods
            // Output: Simulates Output to printer, prints status to console

    }

    public class hd : device
    {
        // Member Fields

        // Constructors
        public hd()
        {

        }

        // Methods
        	// Output: Simulates Output to hard drive, prints status to console
		    // Input: Simulates Input from hard drive, prints status to console
    }

    class keyboard : device
    {
        // Member Fields

        // Constructors
        public keyboard()
        {

        }

        // Methods
        	// Input: Simulates input from keyboard, prints status to console
		    // Interrupt: Calls interrupt function
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Temp Program Holds
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();   

            
            // Initialize System
                // Initialize Classes
                // Read-in, populate memory, set configuration
            // Run
                    // Hand over control to processing module
                        // Process threads, I/O, interrupt monitoring
                    // Loop until end of metadata
            // Shutdown
             
        }
    }
}
