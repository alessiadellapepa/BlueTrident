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
with open('Registrazioni/1874/E/3/Magnetometro.csv') as csv_file:
    csv_reader = csv.DictReader(csv_file)
    csv_reader.fieldnames = "x", "y", "z";
    for riga in csv_reader:
        xdata = float(riga["x"])
        ydata = float(riga["y"])
        zdata = float(riga["z"])
        xs.append(xdata)
        ys.append(ydata)
        zs.append(zdata)
#Create Plot
plot = ax.scatter3D(xs,ys,zs,c=zs,cmap='plasma')

#Modify figure's appearance
fig.colorbar(plot,location='top',shrink=0.7, label='mappatura colore sui vaori di Z')
ax.set_xlabel('x')
ax.set_ylabel('y')
ax.set_zlabel('z')

#Show/Save Plot

#plt.show()
plt.savefig('Registrazioni/Risultati/Magnetometro/MagnetometroE3.png', dpi = 300)
