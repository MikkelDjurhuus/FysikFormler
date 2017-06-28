# FysikFormler
Find den rigtige formel!

## GrapheneDB
Username: test  
Password: b.F7WDytMuJiOJ.Tszh3JzHFT5LUtY9  

Bolt: bolt://hobby-hkinhhmhoeaggbkedfeibipl.dbs.graphenedb.com:24786  
HTTP Rest: http://hobby-hkinhhmhoeaggbkedfeibipl.dbs.graphenedb.com:24789/db/data/  

Cypher: 

'''
match(a)-[r:HAS*]->(b)
where b.symbol in ["kg","m","J"]
with a,count(distinct b.symbol) as b, count(r) as r
return a,b,r
order by b desc
'''


LOAD CSV WITH HEADERS FROM "https://raw.githubusercontent.com/MikkelDjurhuus/FysikFormler/master/Fysiske-St%C3%B8rrelser.csv"  
AS line WITH line  
Merge (e:Enhed {  
    Navn:split(line.Navn,","),  
    Forkortelse:line.Forkortelse,  
    Formel:line.Formel,  
    Enheder:split(line.Enheder,",")  
    })

LOAD CSV WITH HEADERS FROM "https://raw.githubusercontent.com/MikkelDjurhuus/FysikFormler/master/Si-enheder.csv"  
AS line WITH line  
Merge (e:Si {  
    Navn:split(line.Navn,","),  
    Enhed:line.Forkortelse,  
    Forkortelse:line.Formel,  
    Værdi:split(line.Enheder,",")  
    })
