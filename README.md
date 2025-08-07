# 🏃‍♀️ Gestionnaire de Marathon – Projet C# WPF

Bienvenue dans **Marathon Manager**, une application bureautique développée en **C# avec WPF** permettant de **gérer les inscriptions à un marathon** via une interface intuitive. Créez, modifiez, supprimez et consultez les participants à tout moment, avec synchronisation automatique vers une base de données.

---

## 📋 Fonctionnalités principales

- 👤 **Ajout de participants**
  - Nom, prénom, date de naissance, genre
  - Type de course (5km, 10km, semi-marathon, marathon)
  - Lieu de départ, date d’inscription, etc.
- 📄 **Modification et suppression** des fiches participants
- 🔍 **Affichage de la liste complète** des participants enregistrés
- 💾 **Sauvegarde automatique en base de données**
  - Toutes les opérations sont instantanément synchronisées
- 🪟 **Interface WPF ergonomique**
  - Champs de formulaire dynamiques
  - Boutons clairs : Ajouter / Modifier / Supprimer / Actualiser
- 🔄 **Chargement automatique** des données au démarrage

---

## 🖼️ Aperçu de l’interface

> *(Ajoute ici des captures d’écran de ton application : formulaire, tableau, boutons, etc.)*

---

## 🧱 Architecture du projet

- 🧩 Interface : **WPF (Windows Presentation Foundation)**
- 💬 Langage : **C#**
- 🗃️ Base de données : **MySQL** ou **SQLite** (selon ta configuration)
- 🔄 Connexion : `System.Data.SqlClient` ou `MySql.Data.MySqlClient`
- 📁 Architecture MVC ou MVVM (optionnel mais recommandé)

---

## 🚀 Lancer le projet localement

### 1. Cloner le dépôt

```bash
git clone https://github.com/AlinaD-2912/MARATHON.git
cd Marathon-Manager
