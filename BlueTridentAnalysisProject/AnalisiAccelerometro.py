#import libraries
import matplotlib.pyplot as plt
import csv

#Create Figure
fig = plt.figure()
ax = plt.axes(projection='3d')

#Data Definition
xs=[]
ys=[]
zs=[]

#Data Extraction
with open('Registrazioni/1902/BLV/8/HighG.csv') as csv_file:
    csv_reader = csv.DictReader(csv_file)
    csv_reader.fieldnames="x","y","z";
    for riga in csv_reader:
        xdata = float(riga["x"])
        ydata = float(riga["y"])
        zdata = float(riga["z"])
        xs.append(xdata)
        ys.append(ydata)
        zs.append(zdata)

#Create Plot
ax.plot_trisurf(xs,ys,zs,cmap='inferno')

#Modify figure's appearance
ax.view_init(18,-70)
ax.set_xlabel('x')
ax.set_ylabel('y')
ax.set_zlabel('z')

#Show/Save Plot

#plt.show()
plt.savefig('Registrazioni/Risultati/Accelerometro/AHighG_BLV8.png', dpi=300)