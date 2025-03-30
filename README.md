# TestTopOrder

## Description
Le projet étant de consume une api et d'avoir des interactions utilisateur, l'application proposera donc un "tracking" de pays visités.
La base des pays proviendra de l'api donnée en exemple dans l'ennoncé (https://restcountries.com/)
L'utilisateur pourra ajouter un pays visité à partir de la liste fournie par l'api, et préciser l'année et des commentaires.
La visite de n'importe quel endroit étant en soit sur une range de date from/to, mais pour simplifier on utilisera juste l'année.
On aura donc:
- une page d'accueil avec des statistiques
- une page de détails sous forme de datagrid, avec filtres, permettant la gestion (CRUD) des visites.

## Choix techniques
- .Net 8 + Blazor
- Database in memory pour éviter une installation supplémentaire étant donné que ce n'est qu'un test, on aura des données de test au startup et les modifications ne seront pas conservées en fermant le programme.
- Component library: après quelques recherches et curiosité personnelle je vais essayer MudBlazor qui est très populaire et basée sur Material Design, connue pour être plutôt agréable sur le visuel et plutôt complet en fonctionnalités, même si je préfère des approches Bootstrap (Blazorise) je prévois donc de perdre du temps sur l'utilisation d'une librairie inconnue.
- Pas de logging, securité etc...

## Choix UI/UX
- menu horizontal, preferable en tant que navigation principale si peu de liens garde une interface claire

## Temps
2025/03/29 (~20min)
18:50 - 19:10 : init repo github et definition du projet pour répondre à l'énnoncé (Description), petit check et pose des choix techniques
2025/03/03 (~09h35)
09:20 - 11:00 : init project, creation des layers (web, Application, Core, Infrastructure), models (entities, view models, api models), db context, api http client, business features (add, edit, delete)
11:10 - 12:10 : installation mudblazor et creation du design (layout code + css)
14:00 - 14:40 : fin choix design
14:40 - 16:00 : implementation de la page details (affichage en datagrid + CRUD), debugging, ajustement designs
16:30 - 19:00 : suite et fin implementation des details avec generation aléatoire pour agrémenter les tests
19:10 - 19:20 : debut home page choix fonctionnels et UI
21:30 - 22:40 : reprisehome page developpement des cards, graphs
22:40 - 23:45 : test et debugs

## Resources
Microsoft documentation
Stack overflow
Restcountries
ChatGPT
MudBlazor documentation
w3schools
fontawesome
favicon.io
Gemini (drawing)