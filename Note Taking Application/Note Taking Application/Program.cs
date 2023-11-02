using System;
using System.Collections.Generic;

namespace NoteTakingApp
{
    // <summary>
    // Represents a simple note taking application.
    // The application allows users to create, view, and delete notes.
    // </summary>
    public class NoteTakingApplication
    {
        private List<string> notes;

        // <summary>
        // Constructs a new instance of the NoteTakingApplication class.
        // Initializes the notes list.
        // </summary>
        public NoteTakingApplication()
        {
            notes = new List<string>();
        }

        // <summary>
        // Adds a new note to the application.
        //
        // Parameters:
        // - note: The content of the note to be added.
        // </summary>
        public void AddNote(string note)
        {
            notes.Add(note);
        }

        // <summary>
        // Displays all the notes in the application.
        // </summary>
        public void ViewNotes()
        {
            if (notes.Count == 0)
            {
                Console.WriteLine("No notes found.");
            }
            else
            {
                Console.WriteLine("Notes:");
                foreach (string note in notes)
                {
                    Console.WriteLine(note);
                }
            }
        }

        // <summary>
        // Deletes a note from the application.
        //
        // Parameters:
        // - note: The content of the note to be deleted.
        // </summary>
        public void DeleteNote(string note)
        {
            if (notes.Contains(note))
            {
                notes.Remove(note);
                Console.WriteLine("Note deleted successfully.");
            }
            else
            {
                Console.WriteLine("Note not found.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            NoteTakingApplication app = new NoteTakingApplication();

            // Example usage:
            app.AddNote("This is a sample note.");
            app.AddNote("Another note.");

            app.ViewNotes();

            app.DeleteNote("This is a sample note");

            app.ViewNotes();
        }
    }
}