# Design patterns applied to simple examples


| Design Pattern                                   | Description                                                                                           |
|--------------------------------------------------|-------------------------------------------------------------------------------------------------------|
| Abstract Factory                                 | Permet de créer des familles d'objets liés ou dépendants sans spécifier leur classe concrète.         |
| Adapter                                          | Permet de convertir l'interface d'une classe en une autre interface que le client s'attend à utiliser.|
| Aspect Oriented Programming                      | Permet d'isoler les aspects transversaux (par exemple, la sécurité ou la journalisation) du code métier.|
| Bridge                                           | Permet de séparer une abstraction de son implémentation afin que les deux puissent varier indépendamment.|
| Builder                                          | Permet de séparer la construction d'un objet complexe de sa représentation, de sorte que le même processus de construction puisse créer différentes représentations.|
| Bulkhead                                         | Isoler les parties du système en groupes distincts pour éviter que la défaillance d'une partie ne cause la défaillance de l'ensemble du système.|
| Business Delegate                                | Fournit une interface unifiée pour les clients afin d'accéder aux services métier sans connaître les détails de leur implémentation.|
| Chain of Responsibility                          | Permet de traiter une demande au moyen d'un ensemble de traitements, chacun pouvant décider de la manière de la traiter ou de la transmettre au traitement suivant.|
| Circuit Breaker                                  | Intercepte les erreurs et les défaillances d'un système pour éviter les surcharges et préserver la stabilité.|
| Command                                          | Encapsule une demande en une objet, permettant ainsi de paramétrer des clients différents avec des demandes différentes.|
| Command Query Responsibility Segregation (CQRS)  | Sépare les opérations de commande (écriture) et les opérations de requête (lecture) en utilisant des modèles de données différents pour chacune.|
| Composite                                        | Permet de traiter des groupes d'objets de la même manière qu'un seul objet.|
| Composite Entity                                 | Permet de manipuler un groupe de données comme un seul objet, pour faciliter la gestion de transactions.|
| Data Access Object                               | Fournit une interface pour accéder à une base de données ou à un autre système de stockage de données.|
| Decorator                                        | Permet d'ajouter des fonctionnalités à un objet existant de manière dynamique.|
| Dependency Injection                             | Permet d'injecter les dépendances entre les objets, afin de rendre le code plus modulaire et facile à tester.|
| Domain Driven Design (DDD)                       | Une méthode de conception de logiciels centrée sur la modélisation du domaine et la collaboration étroite entre les experts du domaine et les développeurs.|
| Event Sourcing                                   | Permet de stocker les événements qui ont conduit à un état donné, afin de pouvoir le reconstruire ultérieurement.|
| Facade                                           | Fournit une interface unifiée à un ensemble d'interfaces dans un sous-système.|
| Factory                                          | Permet de créer des objets sans spécifier explicitement la classe exacte de l'objet à créer.|
| Flyweight                                        | Permet de partager efficacement des objets qui sont souvent utilisés dans une application.|
| Front Controller                                 | Fournit un point d'entrée centralisé pour gérer les requêtes, gérer la navigation et la sécurité.|
| Intercepting Filter                              | Permet de gérer les demandes et les réponses dans une chaîne de filtres.|
| Interpreter                                      | Définit une grammaire pour un langage et permet l'interprétation de phrases de ce langage.|
| Inversion of Control                             | Permet de déléguer le contrôle de l'exécution à un conteneur de composants.|
| Iterator                                         | Fournit un moyen d'accéder séquentiellement aux éléments d'une collection sans exposer la structure interne de la collection.|
| Mediator                                         | Permet de réduire les dépendances entre les objets en les faisant communiquer uniquement à travers un objet médiateur centralisé.|
| Memento                                          | Permet de capturer l'état d'un objet à un moment donné, afin de pouvoir le restaurer ultérieurement.|
| Message Broker                                   | Permet de distribuer les messages entre les différents composants d'un système.|
| Model-View-Controller (MVC)                      | Sépare les différentes responsabilités de la logique métier, de l'interface utilisateur et du contrôle de la navigation entre les deux.|
| Model-View-Presenter (MVP)                       | Sépare la logique métier de la présentation en utilisant un présentateur qui intermédie entre la vue et le modèle.|
| Model-View-ViewModel (MVVM)                      | Sépare la logique métier de la présentation en utilisant un modèle de vue qui intermédie entre la vue et le modèle.|
| Null Object                                      | Fournit un objet de remplacement qui ne fait rien, afin d'éviter les erreurs de références nulles.|
| Observer                                         | Permet à un objet de notifier d'autres objets lorsqu'un changement d'état se produit.|
| Pipes and Filters                                | Permet de traiter les données en les faisant passer par une série de filtres.|
| Presentation-Abstraction-Control (PAC)           | Structure l'application en trois parties : la présentation, l'abstraction (ou la logique métier) et le contrôle, chacune ayant des responsabilités bien définies.|
| Prototype                                        | Permet de créer de nouveaux objets à partir d'instances existantes, en clonant une instance existante au lieu de créer un nouvel objet à partir de zéro.|
| Proxy                                            | Permet de fournir un substitut ou un espace réservé pour un autre objet afin de contrôler l'accès à cet objet.|
| Repository                                       | Fournit une abstraction pour accéder à des données, en encapsulant la logique d'accès aux données et en permettant de changer facilement la source des données.|
| Retry                                            | Réessaie automatiquement une opération qui a échoué en raison d'une condition temporaire, en évitant une défaillance totale du système.|
| Service Locator                                  | Permet de localiser les services à partir d'un emplacement centralisé.|
| Singleton                                        | Permet de garantir qu'il n'y a qu'une seule instance d'une classe donnée.|
| Specification                                    | Encapsule une logique de validation complexe dans un objet qui peut être réutilisé pour valider différents objets.|
| State                                            | Permet à un objet de modifier son comportement en fonction de son état interne.|
| Strategy                                         | Permet de définir une famille d'algorithmes, de les encapsuler et de les rendre interchangeables.|
| Template Method                                  | Définit le squelette d'un algorithme dans une méthode, en laissant certaines étapes à être définies par des sous-classes.|
| Transfer Object                                  | Fournit un objet de transfert de données qui permet de transférer les données entre les différents composants d'un système.|
| Unit of Work                                     | Encapsule la logique de transaction et de persistance des objets pour garantir que les modifications sont effectuées de manière atomique.|
| Visitor                                          | Permet de séparer l'algorithme de la structure d'un objet sur lequel il opère.|
