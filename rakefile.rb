require 'configatron'

task :default => [ 'config:load', 'unittests:run']

namespace :build do
    
	desc "Use msbuild to build the solution"
	task :compile do
		sh "#{configatron.tools.dotnetpath}msbuild.exe /p:Configuration=#{configatron.build.config} #{configatron.build.solutionpath}"
	end
    
end

namespace :unittests do
    
	desc  "Run unit tests"
	task :run => 'build:compile' do
		sh "#{configatron.tools.xunitpath} src/TestHelpers.Facts/bin/Release/TestHelpers.Facts.dll"
	end
	
end

namespace :config do
    
    task :load do
        configatron.configure_from_yaml 'config.yaml', :hash => 'default'
        configatron.build.number = ENV['BUILD_NUMBER']
    end
    
end
