using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EdiText //Création d'un espace de nommage pour notre application 
{
    public partial class Form1 : Form //Création de la classe Form1 qui hérite de la classe Form
    {
        public Form1() //Constructeur de la classe Form1
        {
            InitializeComponent(); //Initialisation des composants de notre formulaire
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e) //Gestionnaire d'événements pour l'option "Nouveau" du menu
        {
            richTextBox1.Clear(); //Effacement du contenu de la zone de texte
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e) //Gestionnaire d'événements pour l'option "Quitter" du menu
        {
            Application.Exit(); //Fermeture de l'application
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e) //Gestionnaire d'événements pour l'option "Ouvrir" du menu
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Création d'un objet OpenFileDialog pour permettre la sélection d'un fichier
            ofd.Filter = "Text Files (.txt) | *.txt"; //Définition du filtre pour n'afficher que les fichiers texte
            ofd.Title = "Ouverture du fichier..."; //Définition du titre de la boîte de dialogue
            if (ofd.ShowDialog() == DialogResult.OK) //Affichage de la boîte de dialogue et vérification que l'utilisateur a cliqué sur le bouton "OK"
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName); //Création d'un objet StreamReader pour lire le contenu du fichier
                richTextBox1.Text = sr.ReadToEnd(); //Lecture de tout le contenu du fichier et affichage dans la zone de texte
                sr.Close(); //Fermeture du flux de lecture
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e) //Gestionnaire d'événements pour l'option "Enregistrer" du menu
        {
            SaveFileDialog svf = new SaveFileDialog(); //Création d'un objet SaveFileDialog pour permettre la sauvegarde du fichier
            svf.Filter = "Text Files (.txt) | *.txt"; //Définition du filtre pour n'enregistrer que les fichiers texte
            svf.Title = "Sauvegarde du fichier..."; //Définition du titre de la boîte de dialogue
            if (svf.ShowDialog() == DialogResult.OK) //Affichage de la boîte de dialogue et vérification que l'utilisateur a cliqué sur le bouton "OK"
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName); //Création d'un objet StreamWriter pour écrire dans le fichier
                sw.Write(richTextBox1.Text); //Ecriture du contenu de la zone de texte dans le fichier
                sw.Close(); //Fermeture du flux d'écriture
            }
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e) //Gestionnaire d'événements pour l'option "Annuler" du menu
        {
            richTextBox1.Undo(); //Annulation de la précédente action 

        }
        // Méthode appelée lorsque l'utilisateur sélectionne "Rétablir" dans le menu "Edition".
        // Rétablit la dernière action annulée dans le RichTextBox.
        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        // Méthode appelée lorsque l'utilisateur sélectionne "Couper" dans le menu "Edition".
        // Coupe la sélection actuelle dans le RichTextBox et la place dans le presse-papiers.
        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        // Méthode appelée lorsque l'utilisateur sélectionne "Copier" dans le menu "Edition".
        // Copie la sélection actuelle dans le RichTextBox et la place dans le presse-papiers.
        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        // Méthode appelée lorsque l'utilisateur sélectionne "Coller" dans le menu "Edition".
        // Colle le contenu actuel du presse-papiers dans le RichTextBox.
        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        // Méthode appelée lorsque l'utilisateur sélectionne "Sélectionner tout" dans le menu "Edition".
        // Sélectionne tout le contenu du RichTextBox.
        private void sélectionnertoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void enregistrersousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog(); //Création d'un objet SaveFileDialog pour permettre la sauvegarde du fichier
            svf.Filter = "Text Files (.txt) | *.txt"; //Définition du filtre pour n'enregistrer que les fichiers texte
            svf.Title = "Sauvegarde du fichier..."; //Définition du titre de la boîte de dialogue
            if (svf.ShowDialog() == DialogResult.OK) //Affichage de la boîte de dialogue et vérification que l'utilisateur a cliqué sur le bouton "OK"
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName); //Création d'un objet StreamWriter pour écrire dans le fichier
                sw.Write(richTextBox1.Text); //Ecriture du contenu de la zone de texte dans le fichier
                sw.Close(); //Fermeture du flux d'écriture
            }
        }
    }
}
