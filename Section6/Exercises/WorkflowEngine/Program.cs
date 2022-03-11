var videoUploader = new VideoUploader();
var videoEncoder = new VideoEncoder();
var notifyUser = new NotifyUser();
var changeVideoStatus = new ChangeStatusOfVideo();

var workflow = new Workflow();

workflow.AddActivity(videoUploader);
workflow.AddActivity(videoEncoder);
workflow.AddActivity(notifyUser);
workflow.AddActivity(changeVideoStatus);

var workflowExecutor = new WorkflowEngine();
workflowExecutor.Run(workflow);