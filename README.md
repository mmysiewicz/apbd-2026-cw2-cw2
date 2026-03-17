# apbd-2026-cw2-cw2

Change in README for exercise 5.

--zadanie 5
Merge nie był typu fast-forward, ponieważ obie z gałęzi miały wykonane własne, osobne commity.

Change in README for exercise 6.

--zadanie 6
W przypadku wykonania rebase przed merge, przy jednoczesnym posiadaniu własnych commitów na obu gałęziach.
Merge był typu fast-forward.



Odpowiedzi na pytania:
1. Git wykona fast-forward, kiedy commity na gałęziach nie rozchodzą się, ich historia jest liniowa.
   Merge commit powstanie, kiedy każda z gałęzi ma oddzielne commity. Historia commitów tworzy rozgałęzienie.
2. Rebase zmienia historię commitów, przenosi commity z jednej gałęzi na drugą. Tworzy przy tym liniową historię, na której może odbyć się fast-forward.
   Merge nie zmienia historii, a scala w niej rozgałęzienie. Wszystkie commity pozostają zachowane.
3. Konflikt w moim repozytorium został rozwiązany za pomocą wybrania jednej z dwóch wersji kodu zapisanej na gałęziach. Przy jednoczesnym odrzuceniu drugiej.