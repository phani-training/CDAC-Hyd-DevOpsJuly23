# DevOps training by Phaniraj @9945205684
## Subtopics:
1. What is DevOps?
2. Docker
3. Jenkins
4. Microservices
5. Kubernetes.

### What is DevOps?
- There will be 2 teams who collaborate in the Project Deployment cycle. Developer team and the operations team. 
- The developer team will be responsible for Requirement Gathering, Designing, Developing Unit testing, Implementation, Integration and Finally Deployment. 
The stakeholders would be the Product owner, Manager, Team Leads, Senior Programmres, Programmers and QA Team.
- The Operations team will be responsible for Automation Testing, App Evaluation, Integrations and final Deployment. 
- User Acceptance Test will be conducted by one user of the Application(Customer) who understands the process very well and the Application Execution. He/She will ensure that the App meets the requirements in an expected manner. 
- The stake holders would be Automation Testers, Product evaluators, UAT Engineers and customer users who use UR Product. 

#### Challenges in this setup
- Many a time, the Operations team are not aware of the technical parts required for the Application. Even if small modifications are required, they fail to work on the same and resolve it. 
- Integration of multiple config files across the solution will be huge. Sometimes, it might take days to resolve it. 
- Applications are expected to be created partially, deployed and continue the development of the Application: Continuous Integration/Deployment. (CI/CD).
- The solution for all the above problems is Dev + Ops to go together. 
- Dev + Ops will work together from the begining during the Sprint Cycles and do collaborative work on resolving deployment issues like versioning of packages that U use in your App development and helping each other in understanding both the sides of the Project execution. 

### Why DevOps?
- Before DevOps, the Dev and Ops were seperate entities and worked in complete Isolation. But here, with this mindset, the Testing and Development team were isolated and testing was done always after the complete development is done. This consumed more time than the regular short build cycles. Unexpected challenges used to popup with no clue from the developer team. Manual Code deployment used to ahve some human errors in the production Environment that used to take days to resolve.
- With DevOps, S/W delivery is fast and easy. It increases the Deployment easiness. DevOps maintains History which helps in fastening the futher Deployment processes as you have a certain experience over UR previous deployment of the last Sprint. According to the Industry analysts, the Deployments done thru DevOps have increased the speed of the Total Application Delivery(TAD) by over 20%.
- Many of these operations are automated using well tested and popular Tools to do UR work. Git, Docker, Jenkins, Kubernetes are some of the major tools that help in fastening the activities during the development and deployment. 

### How Apps are deployed in Real Time?
With Agile Development methodology, UR Scrum master will plan the sprints. Sprints are short span targets that are realistic and supposed to be met  with the scope of development to be a minor one. The duration of the sprint will be ideally 2-3 weeks. There will be a Sprint planning that includes the divisions of the tasks and given priority, decide on the resources for each task etc. The participants would be 1 Lead, 2 Sr. Engineers, 3 Jr Engineers and a Tester. Initially a Devops person will also be available who sets up the process and explains to the team on how to push the code into the Repository for the CI/CD. During the time, the developers and testers would do the Unit tests and set up the environment for Automation Testing so that when the developer push the code to the REPO, the CI/CD would happen thru tools that will automate the build, Test and Deploy Process. Tools like Git(REPO), Jenkins(CI), Docker(Containers) and K8s (Containerization) will help in this process to make UR Application a success.

### Practical Scenario
1. Task: Get the Employees from a Database.
2. Requirement : Mock the database
3. Implementation: You should create the class that implements the functionality of getting the data from the actual database. U write the test cases that call the object's function on the Mock database. The UT code will assert the results and ensure that the expected no of Employees are matching to the Employees of the Mocked database. 
4. The Ops team will use tools like JENKINs to keep a wathc on the pushes that are made to the code repo. For every update of the code in the REPO will trigger the JENKINS tool to start the building process. It will also automate the tests and gives the report to all the stakeholdres of the project. The cycle will continue for every push that is amde to the CodeRepo
5. Once the successfull tests are completed, the POST BUILD Operations are triggerted by the CI tool, which could be ideally to place the Application in a container like DOCKER that will have the infrastructure replicated as UR Dev Environment and is available for the Users to consume it.
6. Many such containers are organized using a Containerization tool like K8S(Bubernetes) that manages 100s of such indivudual containers with providing back ups if any container fails for some reasons. 
7. Once the Product is complete, it is then pushed to the actual Cloud environment for the usage by the Customers. 
8. If the build fails, the CI Tool would generate Emails to all the stakeholders and will wait for the other builds to continue. The Developer who has pushed the failed code will work and ensure that the build succeeds. 
9. The CI tool will not only build the Code of UR App but also involves in enforcing all the rules and regulations defined by the Organization. If any of the rules are compromised, the build would fail. 

### Benifits of DevOps?
1. Productivity
2. Reproducability
3. Maintainability

### What kind of Apps need DevOps?
- DevOps is required for large distributed Computing Apps like E-Commerce and distributed Environments(Works at different places at the same time with variable no of people working together) that are hosted in a Cloud based Environment. 
- With Agile Dev methodologies, it is easy to practise CI/CD for these kinds of Applications. 
- As the Devops Engineer is involved from the Day 1 of the application process, it helps in development and deployement. 

### Devops Automation Tools
- After the Development is completed, most of the operations need less resources to work. There will be no need for the developer to be available, a DevOps Engineer could do the job. Most of the tasks are routine where we dont need a real time resource to monitor it again and again. 
- Jenkins for CI
- Log4J and Splunk for Logging, Analytics and Storing purposes. 
- Docker for virtualization of UR Application
- Kubernetes for maintaining clustors of Docker Apps that will run various parts of UR Applications as one unit. 

### Docker
- Docker is a centralized platform for packaging, deploying and Running the Application in a closed environment that is created to replicate the actual Dev Environment. It is very similar to VMs but architecturally they are different.
- It is a software platoform that makes UR Apps building process smoother which includes building, running, testing and Managing the Application. It can virtualize the OS of the Computer or any Application software that U want to use in your application. 
- A Docker uses a concept called Containers that creates this closed environment and place UR App/Software in it. With this conntainers, U connect UR Other apps with it and make sure that the App will not fail as it uses the same environment as the development Environment. 

#### Installing Docker in UR Machine:
1. Install WSL(Windows SubSystem for Linux) which is prerequisite for installing Dockers in Windows machine. To install run the following command from the Command Prompt elevated as Administrator
```
wsl --install
```
2. U must restart the machine. Download the Docker desktop app from the Docker Website. If required, U can register and then download the setup and install the software. 
3. Docker will be started immediately at the bootup and one must wait for the docker to start.
4. U can use the docker from the UI available or from the Terminal using the Docker CLI. 

#### Installing Mongodb in UR Docker
1. Run the following commands in the order to install and run the MongoDB inside your docker
```
docker pull mongodb/mongodb-community-server
docker run --name mongo -d mongodb/mongodb-community-server:latest
docker container ls
docker exec -it mongo mongosh
show dbs
```



